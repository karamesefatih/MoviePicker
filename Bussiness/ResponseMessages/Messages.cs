using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ResponseMessages
{
    public class Messages
    {

        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password is incorrect";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "This user already exists";
        public static string UserRegistered = "User stored as password";
        public static string AccessTokenCreated = "Access token completed successfully";

        public static string AuthorizationDenied = "You are not authorized";
        public static string ProductNameAlreadyExists = "Product name already exists";

        public static string MovieAdded = "Movie has been added";
        public static string MovieUpdated = "Movie has been updated";
        public static string MovieDeleted = "Movie has been deleted";
        public static string MoviesListed = "All movies have been listed";
        public static string MoviesListedByCategory = "Movies have been listed by category";
        public static string MoviesListedByImdb = "Movie have been listed by Imdb";

        public static string CategoryAdded = "Category has been added";
        public static string CategoryDeleted = "Category has been deleted";

        public static string WatchListAdded = "User and Movie Paired";
        public static string WatchListDeleted = "User and Movie Dispaired";

    }
}
