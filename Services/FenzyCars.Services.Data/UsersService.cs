namespace FenzyCars.Services.Data
{
    using System;
    using System.IO;
    using System.Linq;

    using FenzyCars.Data;
    using FenzyCars.Data.Models;
    using FenzyCars.Web.ViewModels;
    using Microsoft.AspNetCore.Identity;


    public class UsersService : IUsersService
    {
        private readonly string[] allowedExtensions = new[] { "jpg", "png", "gif" };
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

            var chat = this.CreateChat(input);

            var message = new Message
            {
                Text = input.Message,
                Time = DateTime.UtcNow,
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

                    message.Images.Add(dbImage);

                    var physicalPath = $"{imagePath}/messages/{dbImage.Id}.{extension}";

                    // "/images/cars/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension
                    dbImage.RemoteImageUrl = "/images/messages/" + dbImage.Id + "." + dbImage.Extension;
                    using Stream fileStream = new FileStream(physicalPath, FileMode.Create);
                    image.CopyToAsync(fileStream);
                }
            }

            var userMessage = new UserMessage
            {
                Message = message,
                Reciever = input.Reciever,
                Sender = input.Sender,
            };

            chat.AddMessage(input.senderId, message);

            this.dbContext.Messages.Add(message);
            this.dbContext.UserMessages.Add(userMessage);
            this.dbContext.SaveChanges();
        }

        public Chat CreateChat(UserSendMessageViewModel input)
        {
            var chat = new Chat();

            if (this.dbContext.Chats
                .Any(x => (x.FirstUserId == input.recieverId && x.SecondUserId == input.senderId) ||
                          (x.FirstUserId == input.senderId && x.SecondUserId == input.recieverId)))
            {
                chat = this.dbContext.Chats
                    .Where(x => (x.FirstUserId == input.recieverId && x.SecondUserId == input.senderId) ||
                          (x.FirstUserId == input.senderId && x.SecondUserId == input.recieverId)).FirstOrDefault();
            }

            return chat;
        }
    }
}
