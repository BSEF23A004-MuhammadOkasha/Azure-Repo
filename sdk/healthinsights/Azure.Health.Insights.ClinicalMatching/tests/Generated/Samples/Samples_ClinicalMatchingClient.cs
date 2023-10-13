// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Health.Insights.ClinicalMatching;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Health.Insights.ClinicalMatching.Samples
{
    public partial class Samples_ClinicalMatchingClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MatchTrials_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                patients = new object[]
            {
new
{
id = "<id>",
}
            },
            });
            Operation operation = client.MatchTrials(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                patients = new object[]
            {
new
{
id = "<id>",
}
            },
            });
            Operation operation = await client.MatchTrialsAsync(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MatchTrials_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            TrialMatcherData trialMatcherData = new TrialMatcherData(new PatientRecord[]
            {
new PatientRecord("<id>")
            });
            Operation operation = client.MatchTrials(WaitUntil.Completed, trialMatcherData);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            TrialMatcherData trialMatcherData = new TrialMatcherData(new PatientRecord[]
            {
new PatientRecord("<id>")
            });
            Operation operation = await client.MatchTrialsAsync(WaitUntil.Completed, trialMatcherData);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MatchTrials_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                patients = new object[]
            {
new
{
id = "<id>",
info = new
{
sex = "female",
birthDate = "2022-05-10",
clinicalInfo = new object[]
{
new
{
system = "<system>",
code = "<code>",
name = "<name>",
value = "<value>",
}
},
},
data = new object[]
{
new
{
type = "note",
clinicalType = "consultation",
id = "<id>",
language = "<language>",
createdDateTime = "2022-05-10T14:57:31.2311892-04:00",
content = new
{
sourceType = "inline",
value = "<value>",
},
}
},
}
            },
                configuration = new
                {
                    verbose = true,
                    includeEvidence = true,
                    clinicalTrials = new
                    {
                        customTrials = new object[]
            {
new
{
id = "<id>",
eligibilityCriteriaText = "<eligibilityCriteriaText>",
demographics = new
{
acceptedSex = "all",
acceptedAgeRange = new
{
minimumAge = new
{
unit = "years",
value = 123.45F,
},
},
},
metadata = new
{
phases = new object[]
{
"notApplicable"
},
studyType = "interventional",
recruitmentStatus = "unknownStatus",
conditions = new object[]
{
"<conditions>"
},
sponsors = new object[]
{
"<sponsors>"
},
contacts = new object[]
{
new
{
name = "<name>",
email = "<email>",
phone = "<phone>",
}
},
facilities = new object[]
{
new
{
name = "<name>",
city = "<city>",
state = "<state>",
countryOrRegion = "<countryOrRegion>",
}
},
},
}
            },
                        registryFilters = new object[]
            {
new
{
conditions = new object[]
{
"<conditions>"
},
studyTypes = new object[]
{
"interventional"
},
recruitmentStatuses = new object[]
{
"unknownStatus"
},
sponsors = new object[]
{
"<sponsors>"
},
phases = new object[]
{
"notApplicable"
},
purposes = new object[]
{
"notApplicable"
},
ids = new object[]
{
"<ids>"
},
sources = new object[]
{
"custom"
},
facilityNames = new object[]
{
"<facilityNames>"
},
facilityLocations = new object[]
{
new
{
city = "<city>",
state = "<state>",
countryOrRegion = "<countryOrRegion>",
}
},
facilityAreas = new object[]
{
new
{
type = "Feature",
geometry = new
{
type = "Point",
coordinates = new object[]
{
123.45F
},
},
properties = new
{
subType = "Circle",
radius = 123.45,
},
}
},
}
            },
                    },
                },
            });
            Operation operation = client.MatchTrials(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                patients = new object[]
            {
new
{
id = "<id>",
info = new
{
sex = "female",
birthDate = "2022-05-10",
clinicalInfo = new object[]
{
new
{
system = "<system>",
code = "<code>",
name = "<name>",
value = "<value>",
}
},
},
data = new object[]
{
new
{
type = "note",
clinicalType = "consultation",
id = "<id>",
language = "<language>",
createdDateTime = "2022-05-10T14:57:31.2311892-04:00",
content = new
{
sourceType = "inline",
value = "<value>",
},
}
},
}
            },
                configuration = new
                {
                    verbose = true,
                    includeEvidence = true,
                    clinicalTrials = new
                    {
                        customTrials = new object[]
            {
new
{
id = "<id>",
eligibilityCriteriaText = "<eligibilityCriteriaText>",
demographics = new
{
acceptedSex = "all",
acceptedAgeRange = new
{
minimumAge = new
{
unit = "years",
value = 123.45F,
},
},
},
metadata = new
{
phases = new object[]
{
"notApplicable"
},
studyType = "interventional",
recruitmentStatus = "unknownStatus",
conditions = new object[]
{
"<conditions>"
},
sponsors = new object[]
{
"<sponsors>"
},
contacts = new object[]
{
new
{
name = "<name>",
email = "<email>",
phone = "<phone>",
}
},
facilities = new object[]
{
new
{
name = "<name>",
city = "<city>",
state = "<state>",
countryOrRegion = "<countryOrRegion>",
}
},
},
}
            },
                        registryFilters = new object[]
            {
new
{
conditions = new object[]
{
"<conditions>"
},
studyTypes = new object[]
{
"interventional"
},
recruitmentStatuses = new object[]
{
"unknownStatus"
},
sponsors = new object[]
{
"<sponsors>"
},
phases = new object[]
{
"notApplicable"
},
purposes = new object[]
{
"notApplicable"
},
ids = new object[]
{
"<ids>"
},
sources = new object[]
{
"custom"
},
facilityNames = new object[]
{
"<facilityNames>"
},
facilityLocations = new object[]
{
new
{
city = "<city>",
state = "<state>",
countryOrRegion = "<countryOrRegion>",
}
},
facilityAreas = new object[]
{
new
{
type = "Feature",
geometry = new
{
type = "Point",
coordinates = new object[]
{
123.45F
},
},
properties = new
{
subType = "Circle",
radius = 123.45,
},
}
},
}
            },
                    },
                },
            });
            Operation operation = await client.MatchTrialsAsync(WaitUntil.Completed, content);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MatchTrials_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            TrialMatcherData trialMatcherData = new TrialMatcherData(new PatientRecord[]
            {
new PatientRecord("<id>")
{
Info = new PatientInfo
{
Sex = PatientInfoSex.Female,
BirthDate = DateTimeOffset.Parse("2022-05-10"),
ClinicalInfo = {new ClinicalCodedElement("<system>", "<code>")
{
Name = "<name>",
Value = "<value>",
}},
},
Data = {new PatientDocument(DocumentType.Note, "<id>", new DocumentContent(DocumentContentSourceType.Inline, "<value>"))
{
ClinicalType = ClinicalDocumentType.Consultation,
Language = "<language>",
CreatedDateTime = DateTimeOffset.Parse("2022-05-10T14:57:31.2311892-04:00"),
}},
}
            })
            {
                Configuration = new TrialMatcherModelConfiguration(new ClinicalTrials
                {
                    CustomTrials = {new ClinicalTrialDetails("<id>", new ClinicalTrialMetadata(new string[]{"<conditions>"})
{
Phases = {ClinicalTrialPhase.NotApplicable},
StudyType = ClinicalTrialStudyType.Interventional,
RecruitmentStatus = ClinicalTrialRecruitmentStatus.UnknownStatus,
Sponsors = {"<sponsors>"},
Contacts = {new ContactDetails
{
Name = "<name>",
Email = "<email>",
Phone = "<phone>",
}},
Facilities = {new ClinicalTrialResearchFacility("<name>", "<countryOrRegion>")
{
City = "<city>",
State = "<state>",
}},
})
{
EligibilityCriteriaText = "<eligibilityCriteriaText>",
Demographics = new ClinicalTrialDemographics
{
AcceptedSex = ClinicalTrialAcceptedSex.All,
AcceptedAgeRange = new AcceptedAgeRange
{
MinimumAge = new AcceptedAge(AgeUnit.Years, 123.45F),
MaximumAge = default,
},
},
}},
                    RegistryFilters = {new ClinicalTrialRegistryFilter
{
Conditions = {"<conditions>"},
StudyTypes = {ClinicalTrialStudyType.Interventional},
RecruitmentStatuses = {ClinicalTrialRecruitmentStatus.UnknownStatus},
Sponsors = {"<sponsors>"},
Phases = {ClinicalTrialPhase.NotApplicable},
Purposes = {ClinicalTrialPurpose.NotApplicable},
Ids = {"<ids>"},
Sources = {ClinicalTrialSource.Custom},
FacilityNames = {"<facilityNames>"},
FacilityLocations = {new GeographicLocation("<countryOrRegion>")
{
City = "<city>",
State = "<state>",
}},
FacilityAreas = {new GeographicArea(GeoJsonType.Feature, new AreaGeometry(GeoJsonGeometryType.Point, new float[]{123.45F}), new AreaProperties(GeoJsonPropertiesSubType.Circle, 123.45))},
}},
                })
                {
                    Verbose = true,
                    IncludeEvidence = true,
                },
            };
            Operation operation = client.MatchTrials(WaitUntil.Completed, trialMatcherData);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MatchTrials_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ClinicalMatchingClient client = new ClinicalMatchingClient(endpoint, credential);

            TrialMatcherData trialMatcherData = new TrialMatcherData(new PatientRecord[]
            {
new PatientRecord("<id>")
{
Info = new PatientInfo
{
Sex = PatientInfoSex.Female,
BirthDate = DateTimeOffset.Parse("2022-05-10"),
ClinicalInfo = {new ClinicalCodedElement("<system>", "<code>")
{
Name = "<name>",
Value = "<value>",
}},
},
Data = {new PatientDocument(DocumentType.Note, "<id>", new DocumentContent(DocumentContentSourceType.Inline, "<value>"))
{
ClinicalType = ClinicalDocumentType.Consultation,
Language = "<language>",
CreatedDateTime = DateTimeOffset.Parse("2022-05-10T14:57:31.2311892-04:00"),
}},
}
            })
            {
                Configuration = new TrialMatcherModelConfiguration(new ClinicalTrials
                {
                    CustomTrials = {new ClinicalTrialDetails("<id>", new ClinicalTrialMetadata(new string[]{"<conditions>"})
{
Phases = {ClinicalTrialPhase.NotApplicable},
StudyType = ClinicalTrialStudyType.Interventional,
RecruitmentStatus = ClinicalTrialRecruitmentStatus.UnknownStatus,
Sponsors = {"<sponsors>"},
Contacts = {new ContactDetails
{
Name = "<name>",
Email = "<email>",
Phone = "<phone>",
}},
Facilities = {new ClinicalTrialResearchFacility("<name>", "<countryOrRegion>")
{
City = "<city>",
State = "<state>",
}},
})
{
EligibilityCriteriaText = "<eligibilityCriteriaText>",
Demographics = new ClinicalTrialDemographics
{
AcceptedSex = ClinicalTrialAcceptedSex.All,
AcceptedAgeRange = new AcceptedAgeRange
{
MinimumAge = new AcceptedAge(AgeUnit.Years, 123.45F),
MaximumAge = default,
},
},
}},
                    RegistryFilters = {new ClinicalTrialRegistryFilter
{
Conditions = {"<conditions>"},
StudyTypes = {ClinicalTrialStudyType.Interventional},
RecruitmentStatuses = {ClinicalTrialRecruitmentStatus.UnknownStatus},
Sponsors = {"<sponsors>"},
Phases = {ClinicalTrialPhase.NotApplicable},
Purposes = {ClinicalTrialPurpose.NotApplicable},
Ids = {"<ids>"},
Sources = {ClinicalTrialSource.Custom},
FacilityNames = {"<facilityNames>"},
FacilityLocations = {new GeographicLocation("<countryOrRegion>")
{
City = "<city>",
State = "<state>",
}},
FacilityAreas = {new GeographicArea(GeoJsonType.Feature, new AreaGeometry(GeoJsonGeometryType.Point, new float[]{123.45F}), new AreaProperties(GeoJsonPropertiesSubType.Circle, 123.45))},
}},
                })
                {
                    Verbose = true,
                    IncludeEvidence = true,
                },
            };
            Operation operation = await client.MatchTrialsAsync(WaitUntil.Completed, trialMatcherData);
        }
    }
}
