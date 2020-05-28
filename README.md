# ODataOffsetProblemPOC
POC for problem when generating Odata nextlink skip token with date containing offset

There is a problem when using Odata Web API with dates that are not in UTC time zone.
When we get the first page of data there is a nextlink with skip token generated, like so:

"@odata.nextLink":"https://localhost:44331/odata/weatherforecast?$skiptoken=StartDate-2020-05-29T08:48:29.2464819+01:00"

This is problematic. because of the special characters like '+', that cannot be passed as a query string parameter.
So when we use this link we get the following exception:

The query specified in the URI is not valid. The DateTimeOffset text '2020-05-28T14:13:18.3086363' should be in format 'yyyy-mm-ddThh:mm:ss('.'s+)?(zzzzzz)?' and each field value is within valid range.

For the generated nextlink to work the skip token must be encoded, like so:

"@odata.nextLink":"https://localhost:44331/odata/weatherforecast?$skiptoken=StartDate-2020-05-29T08%3A48%3A29.2464819%2B01%3A00"
