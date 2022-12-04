# contacts-api-dotnet
A Contacts API built with .Net 6 and Entity Framework Core which stores contact information for any person<br>
The API implements CRUD operations<br>
The API stores the data using In-Memory Database as well as SQL Database<br>
The SQL Database operations are performed using Entity Framework Core & EF Migrations<br>
<br>
The API is built based on the YouTube video [ASP.NET Core Web API CRUD With Entity Framework - Full Course ⭐ [.NET6 API]](https://www.youtube.com/watch?v=3NWT9k-6xGg)
<br>
# Usage

Simply run `git clone https://github.com/saideepd/contacts-api-dotnet` and `dotnet run --project ContactsAPI`.
<br><br>

# API Definition

## Get Contact

### Get All Contacts Request

```js
GET /api/Contacts
```
### Get All Contacts Response

```js
200 OK
```

```json
[
  {
    "id": "eef37882-168a-4e70-9681-19ecda2efe0e",
    "fullName": "John Doe",
    "email": "john.doe@email.com",
    "phone": 1234567890,
    "address": "221B Blecker Street, Old Town, NYC, USA"
  },
  {
    "id": "1cc685ab-5ddc-4fcc-8b30-fea17f555617",
    "fullName": "Jane Doe",
    "email": "jane.doe@email.com",
    "phone": 8989898081,
    "address": "34th Bull Street, Manhattan, NJ, USA"
  }
]
```

### Get Single Contact Request

```js
GET /api/Contact/{{id}}
```
### Get Contact Response

```js
200 OK
```

```json
[
  {
    "id": "1cc685ab-5ddc-4fcc-8b30-fea17f555617",
    "fullName": "Jane Doe",
    "email": "jane.doe@email.com",
    "phone": 8989898081,
    "address": "34th Bull Street, Manhattan, NJ, USA"
  }
]
```

## Create Contact

### Create Contact Request

```js
POST /api/Contacts
```
### Create Contact Response

```js
200 OK
```

```json
[
  {
    "id": "1cc685ab-5ddc-4fcc-8b30-fea17f555617",
    "fullName": "Jane Doe",
    "email": "jane.doe@email.com",
    "phone": 8989898081,
    "address": "34th Bull Street, Manhattan, NJ, USA"
  }
]
```

## Update Contact

### Update Contact Request

```js
PUT /api/Contacts/{{id}}
```
### Update Contact Response

```js
200 OK
```

```json
[
  {
    "id": "1cc685ab-5ddc-4fcc-8b30-fea17f555617",
    "fullName": "Janet Dane",
    "email": "janet.dane@email.com",
    "phone": 8989898081,
    "address": "221B Baker Street, London, UK"
  }
]
```


## Delete Contact

### Delete Contact Request

```js
DELETE /api/Contacts/{{id}}
```
### Delete Contact Response

```js
200 OK
```

```json
[
  {
    "id": "1cc685ab-5ddc-4fcc-8b30-fea17f555617",
    "fullName": "Janet Dane",
    "email": "janet.dane@email.com",
    "phone": 8989898081,
    "address": "221B Baker Street, London, UK"
  }
]
```

## Unsuccessful Requests
If any of the API does not have matching record present in Database to perform the respective operations, then the API returns 404 Not Found as response

### API Requests

```js
GET /api/Contact/{{id}}
```
```js
PUT /api/Contacts/{{id}}
```
```js
DELETE /api/Contacts/{{id}}
```

### Unsuccessful Request Response
```js
404 Not Found
```
```json
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.4",
  "title": "Not Found",
  "status": 404,
  "traceId": "00-049191ed4040ae3b5fcb8cbb09908cc7-d69eb9f86a77c0f0-00"
}
```
