using Gov.Jag.Embc.Public.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Gov.Jag.Embc.Public.DataInterfaces
{
    public static class UserExtensions
    {
        /// <summary>
        /// Load User from database using their userId and guid
        /// </summary>
        /// <param name="context"></param>
        /// <param name="siteminderGuid"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static async Task<User> LoadUser(this IDataInterface _dataInterface, string siteminderGuid, IHeaderDictionary Headers, ILogger _logger, string guid = null)
        {
            User user = null;
            ViewModels.Volunteer contact = null;
            Guid userGuid;

            if (!string.IsNullOrEmpty(guid))
            {
                user = await _dataInterface.GetUserByGuid(guid);
            }

            if (user == null)
            {
                _logger.LogInformation(">>>> LoadUser for BCEID.");
                user = _dataInterface.GetUserByExternalId(siteminderGuid);
                if (user != null)
                {
                    _logger.LogInformation(">>>> LoadUser for BCEID: user != null");

                    // if you wish to update the contact with Siteminder headers, do it here.
                }
            }

            if (user == null)
                return null;

            if (guid == null)
                return user;

            if (!user.ContactId.ToString().Equals(guid, StringComparison.OrdinalIgnoreCase))
            {
                // invalid account - guid doesn't match user credential
                return null;
            }

            return user;
        }

        /// <summary>
        /// Convert a service card ID string into a format that is useful (and fits into Dynamics)
        /// </summary>
        /// <param name="raw"></param>
        /// <returns></returns>
        public static string GetServiceCardID(string raw)
        {
            string result = "";
            if (!string.IsNullOrEmpty(raw))
            {
                var tokens = raw.Split('|');
                if (tokens.Length > 0)
                {
                    result = tokens[0];
                }

                if (!string.IsNullOrEmpty(result))
                {
                    tokens = result.Split(':');
                    result = tokens[tokens.Length - 1];
                }
            }

            return result;
        }

        /// <summary>
        /// Returns a User based on the guid
        /// </summary>
        /// <param name="context"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static async Task<User> GetUserByGuid(this IDataInterface _dataInterface, string guid)
        {
            Guid id = new Guid(guid);
            User user = null;
            var contact = _dataInterface.GetVolunteerById(guid);
            if (contact != null)
            {
                user = new User();
                user.FromVolunteer(contact);
            }

            return user;
        }

        /// <summary>
        /// Returns a User based on the guid
        /// </summary>
        /// <param name="context"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static User GetUserByExternalId(this IDataInterface _dataInterface, string guid)
        {
            User user = null;
            var contact = _dataInterface.GetVolunteerByExternalId(guid);
            if (contact != null)
            {
                user = new User();
                user.FromVolunteer(contact);
            }

            return user;
        }

        /// <summary>
        /// Copy values from a Dynamics legal entity to another one
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        public static void FromVolunteer(this User to, ViewModels.Volunteer from)
        {
            if (from.Id != null)
            {
                to.ContactId = Guid.Parse(from.Id);
            }

            if (from.Organization != null && from.Organization.Id != null)
            {
                to.AccountId = Guid.Parse(from.Organization.Id);
            }

            to.GivenName = from.FirstName;
            to.Surname = from.LastName;
            to.SmUserId = from.BceidAccountNumber;
            to.SiteMinderGuid = from.Externaluseridentifier;
            to.Email = from.Email;
            to.Active = true;
        }
    }
}
