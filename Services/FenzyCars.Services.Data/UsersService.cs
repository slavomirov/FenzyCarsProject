namespace FenzyCars.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using FenzyCars.Services.Mapping;
    using FenzyCars.Web.ViewModels;
    using FenzyCars.Web.ViewModels.Messages;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class UsersService : IUsersService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif", "jpeg" };
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public UsersService(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public ApplicationUser GetUserById(string id)
        {
            return this.dbContext.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public void SendMessage(UserSendMessageViewModel input, string imagePath)
        {
            input.Reciever = this.GetUserById(input.recieverId);
            input.Sender = this.GetUserById(input.senderId);

            var sendedMessage = new SendedMessage
            {
                Text = input.Message,
                Time = DateTime.UtcNow,
                Reciever = input.Reciever,
                SenderId = input.senderId,
            };

            var recievedMessage = new RecievedMessage
            {
                Text = input.Message,
                Time = DateTime.UtcNow,
                Sender = input.Sender,
                RecieverId = input.recieverId,
            };

            if (input.Images.Count > 0)
            {
                Directory.CreateDirectory($"{imagePath}/messages/");

                foreach (var image in input.Images)
                {
                    var extension = Path.GetExtension(image.FileName).TrimStart('.');

                    if (!this.allowedExtensions.Any(x => extension.EndsWith(x)))
                    {
                        throw new Exception($"Invalid image extension {extension}");
                    }

                    var dbImage = new Image
                    {
                        AddedByUserId = input.senderId,
                        Extension = extension,
                    };

                    sendedMessage.Images.Add(dbImage);
                    recievedMessage.Images.Add(dbImage);

                    var physicalPath = $"{imagePath}/messages/{dbImage.Id}.{extension}";

                    // "/images/cars/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension
                    dbImage.RemoteImageUrl = "/images/messages/" + dbImage.Id + "." + dbImage.Extension;
                    using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                    image.CopyToAsync(fileStream);
                }
            }

            var userRecievedMessage = new UserRecievedMessages
            {
                Message = recievedMessage,
                Sender = input.Sender,
            };

            var userSendedMessage = new UserSendedMessages
            {
                Message = sendedMessage,
                Reciever = input.Reciever,
            };

            this.dbContext.RecievedMessages.Add(recievedMessage);
            this.dbContext.UserRecievedMessages.Add(userRecievedMessage);

            this.dbContext.SendedMessages.Add(sendedMessage);
            this.dbContext.UserSendedMessages.Add(userSendedMessage);

            this.dbContext.SaveChanges();
        }

        public IEnumerable<RecievedMessagesInListViewModel> GetAllRecieved(int page, string userId, int itemsPerPage = 4)
        {
            return this.dbContext.RecievedMessages.AsNoTracking()
                .Where(x => x.RecieverId == userId)
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .To<RecievedMessagesInListViewModel>()
                .ToList();
        }

        public int GetRecievedCount(string userId)
        {
           return this.dbContext.RecievedMessages.Where(x => x.RecieverId == userId).Count();
        }

        public IEnumerable<SendedMessagesInListViewModel> GetAllSended(int page, string userId, int itemsPerPage = 4)
        {
            return this.dbContext.SendedMessages.AsNoTracking()
                .Where(x => x.SenderId == userId)
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .To<SendedMessagesInListViewModel>()
                .ToList();
        }

        public int GetSendedCount(string userId)
        {
            return this.dbContext.SendedMessages.Where(x => x.SenderId == userId).Count();
        }
    }
}