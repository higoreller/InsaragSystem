using InsaragSystem.Domain.Entities;
using InsaragSystem.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Validations
{
    public static class ContactDetailsValidation
    {
        public const int MaxNameLength = 100;
        public const int MaxPhoneNumberLength = 15;
        public const int MaxEmailLength = 255;
        public const int MinEmailLength = 5;
        public static readonly Regex EmailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

        public static void ValidateContactName(string contactName)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(contactName), "Contact name cannot be null or whitespace.");
            DomainExceptionValidation.When(contactName.Length > MaxNameLength, $"Contact name cannot be more than {MaxNameLength} characters.");
        }

        public static void ValidateMobilePhoneNumber(string phoneNumber)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(phoneNumber), "Phone number cannot be null or whitespace.");
            DomainExceptionValidation.When(phoneNumber.Length > MaxPhoneNumberLength, $"Phone number cannot be more than {MaxPhoneNumberLength} characters.");
        }

        public static void ValidateSatellitePhoneNumber(string satellitePhoneNumber)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(satellitePhoneNumber), "Satellite phone number cannot be null or whitespace.");
            DomainExceptionValidation.When(satellitePhoneNumber.Length > MaxPhoneNumberLength, $"Satellite phone number cannot be more than {MaxPhoneNumberLength} characters.");
        }

        public static void ValidateEmail(string email)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(email), "Email cannot be null or whitespace.");
            DomainExceptionValidation.When(email.Length < MinEmailLength || email.Length > MaxEmailLength, $"Email should be between {MinEmailLength} and {MaxEmailLength} characters long.");
            DomainExceptionValidation.When(!EmailRegex.IsMatch(email), "Invalid email format.");
        }

        public static void ValidateBaseOperationLocation(string baseOperationLocation)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(baseOperationLocation), "Base operation location cannot be null or whitespace.");
        }

        public static void ValidateRadioFrequency(string radioFrequency)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(radioFrequency), "Radio frequency cannot be null or whitespace.");
        }

        public static void ValidateGpsCoordinates(GpsCoordinates gpsCoordinates)
        {
            DomainExceptionValidation.When(gpsCoordinates == null, "GPS Coordinates cannot be null.");
        }
    }
}
