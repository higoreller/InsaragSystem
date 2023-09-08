using InsaragSystem.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Team
{
    public sealed class ContactDetails : TeamBase
    {
        public string Contact1NameOrTitle { get; private set; }
        public string Contact1MobilePhoneNumber { get; private set; }
        public string Contact1SatellitePhoneNumber { get; private set; }
        public string Contact1Email { get; private set; }
        public string Contact2NameOrTitle { get; private set; }
        public string Contact2MobilePhoneNumber { get; private set; }
        public string Contact2SatellitePhoneNumber { get; private set; }
        public string Contact2Email { get; private set; }
        public string BaseOperationLocation { get; private set; }
        public string RadioFrequencyInMHz { get; private set; }
        public string WorkSiteGpsCoordinates { get; private set; }

        private ContactDetails() { }

        public void Update(
            string contact1NameOrTitle,
            string contact1MobilePhoneNumber,
            string contact1SatellitePhoneNumber,
            string contact1Email,
            string contact2NameOrTitle,
            string contact2MobilePhoneNumber,
            string contact2SatellitePhoneNumber,
            string contact2Email,
            string baseOperationLocation,
            string radioFrequencyInMHz,
            string workSiteGpsCoordinates)
        {
            var builder = new Builder()
                .WithContact1NameOrTitle(contact1NameOrTitle)
                .WithContact1MobilePhoneNumber(contact1MobilePhoneNumber)
                .WithContact1SatellitePhoneNumber(contact1SatellitePhoneNumber)
                .WithContact1Email(contact1Email)
                .WithContact2NameOrTitle(contact2NameOrTitle)
                .WithContact2MobilePhoneNumber(contact2MobilePhoneNumber)
                .WithContact2SatellitePhoneNumber(contact2SatellitePhoneNumber)
                .WithContact2Email(contact2Email)
                .WithBaseOperationLocation(baseOperationLocation)
                .WithRadioFrequencyInMHz(radioFrequencyInMHz)
                .WithWorkSiteGpsCoordinates(workSiteGpsCoordinates);

            var updatedContactDetails = builder.Build();

            Contact1NameOrTitle = updatedContactDetails.Contact1NameOrTitle;
            Contact1MobilePhoneNumber = updatedContactDetails.Contact1MobilePhoneNumber;
            Contact1SatellitePhoneNumber = updatedContactDetails.Contact1SatellitePhoneNumber;
            Contact1Email = updatedContactDetails.Contact1Email;
            Contact2NameOrTitle = updatedContactDetails.Contact2NameOrTitle;
            Contact2MobilePhoneNumber = updatedContactDetails.Contact2MobilePhoneNumber;
            Contact2SatellitePhoneNumber = updatedContactDetails.Contact2SatellitePhoneNumber;
            Contact2Email = updatedContactDetails.Contact2Email;
            BaseOperationLocation = updatedContactDetails.BaseOperationLocation;
            RadioFrequencyInMHz = updatedContactDetails.RadioFrequencyInMHz;
            WorkSiteGpsCoordinates = updatedContactDetails.WorkSiteGpsCoordinates;
        }

        public class Builder
        {
            private readonly ContactDetails _contactDetails = new();

            private static void ValidateDomain(string propertyName, string value)
            {
                switch (propertyName)
                {
                    case nameof(Contact1NameOrTitle):
                    case nameof(Contact1MobilePhoneNumber):
                    case nameof(Contact1SatellitePhoneNumber):
                    case nameof(Contact1Email):
                        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(value), $"{propertyName} cannot be null or whitespace.");
                        break;
                    case nameof(Contact2NameOrTitle):
                    case nameof(Contact2MobilePhoneNumber):
                    case nameof(Contact2SatellitePhoneNumber):
                    case nameof(Contact2Email):
                    case nameof(BaseOperationLocation):
                    case nameof(RadioFrequencyInMHz):
                    case nameof(WorkSiteGpsCoordinates):
                        break;
                }
            }

            public Builder WithContact1NameOrTitle(string contact1NameOrTitle)
            {
                ValidateDomain(nameof(Contact1NameOrTitle), contact1NameOrTitle);
                _contactDetails.Contact1NameOrTitle = contact1NameOrTitle;
                return this;
            }

            public Builder WithContact1MobilePhoneNumber(string contact1MobilePhoneNumber)
            {
                ValidateDomain(nameof(Contact1MobilePhoneNumber), contact1MobilePhoneNumber);
                _contactDetails.Contact1MobilePhoneNumber = contact1MobilePhoneNumber;
                return this;
            }

            public Builder WithContact1SatellitePhoneNumber(string contact1SatellitePhoneNumber)
            {
                ValidateDomain(nameof(Contact1SatellitePhoneNumber), contact1SatellitePhoneNumber);
                _contactDetails.Contact1SatellitePhoneNumber = contact1SatellitePhoneNumber;
                return this;
            }

            public Builder WithContact1Email(string contact1Email)
            {
                ValidateDomain(nameof(Contact1Email), contact1Email);
                _contactDetails.Contact1Email = contact1Email;
                return this;
            }

            public Builder WithContact2NameOrTitle(string contact2NameOrTitle)
            {
                ValidateDomain(nameof(Contact2NameOrTitle), contact2NameOrTitle);
                _contactDetails.Contact2NameOrTitle = contact2NameOrTitle;
                return this;
            }

            public Builder WithContact2MobilePhoneNumber(string contact2MobilePhoneNumber)
            {
                ValidateDomain(nameof(Contact2MobilePhoneNumber), contact2MobilePhoneNumber);
                _contactDetails.Contact2MobilePhoneNumber = contact2MobilePhoneNumber;
                return this;
            }

            public Builder WithContact2SatellitePhoneNumber(string contact2SatellitePhoneNumber)
            {
                ValidateDomain(nameof(Contact2SatellitePhoneNumber), contact2SatellitePhoneNumber);
                _contactDetails.Contact2SatellitePhoneNumber = contact2SatellitePhoneNumber;
                return this;
            }

            public Builder WithContact2Email(string contact2Email)
            {
                ValidateDomain(nameof(Contact2Email), contact2Email);
                _contactDetails.Contact2Email = contact2Email;
                return this;
            }

            public Builder WithBaseOperationLocation(string baseOperationLocation)
            {
                ValidateDomain(nameof(BaseOperationLocation), baseOperationLocation);
                _contactDetails.BaseOperationLocation = baseOperationLocation;
                return this;
            }

            public Builder WithRadioFrequencyInMHz(string radioFrequencyInMHz)
            {
                ValidateDomain(nameof(RadioFrequencyInMHz), radioFrequencyInMHz);
                _contactDetails.RadioFrequencyInMHz = radioFrequencyInMHz;
                return this;
            }

            public Builder WithWorkSiteGpsCoordinates(string workSiteGpsCoordinates)
            {
                ValidateDomain(nameof(WorkSiteGpsCoordinates), workSiteGpsCoordinates);
                _contactDetails.WorkSiteGpsCoordinates = workSiteGpsCoordinates;
                return this;
            }

            public ContactDetails Build()
            {
                return _contactDetails;
            }
        }
    }
}
