using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Core.Constants
{
    public class Messages
    {
        public class GlobalMessages
        {
            public static string DATA_LISTED_SUCCESSFULLY = "Data Listed Successfully: ";
            public static string DATA_ADDED_SUCCESSFULLY = "Data Added Successfully: ";
            public static string DATA_UPDATED_SUCCESSFULLY = "Data updated successfully: ";
            public static string DATA_DELETED_SUCCESSFULLY = "Data deleted successfully: ";
        }
        public class AuthorizationMessages
        {
            public static string AUTHORIZATION_DENIED = "Authorization Denied: ";
            public static string USER_REGISTERED = "User Registered: ";
            public static string USER_NOT_FOUND = "User Not Found: ";
            public static string PASSWORD_ERROR = "Password Error: ";
            public static string USER_ALREADY_EXISTS = "User Already Exists: ";
            public static string ACCESS_TOKEN_CREATED = "Access Token Created: ";
            public static string LOGIN_SUCCESSFULL = "Login Successfull: ";
        }
        public class UserMessages
        {
            public static string USER_ = "Password Error: ";
        }
    }
}
