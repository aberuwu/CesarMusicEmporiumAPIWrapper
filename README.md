# CesarMusicEmporium API Documentation

Welcome to the CesarMusicEmporium API! This API provides access to music albums and artists data stored in our database. This document outlines the available endpoints and their corresponding requests and responses.

## Base URL

### Live endpoint URL: 
- https://cesarmusicemporiumapi.azurewebsites.net/api/Albums
- https://cesarmusicemporiumapi.azurewebsites.net/api/Artists
- The base URL for local requests is `https://{localhost}/api/{Albums/Artists}`.

## How to Run Demo App and API

### LIVE API ENDPOINT CALL EXAMPLES DEMO
- https://cesarmusicemporiumapi.azurewebsites.net/api/Albums (Get All Albums)
- https://cesarmusicemporiumapi.azurewebsites.net/api/Artists (Get All Artists)
- https://cesarmusicemporiumapi.azurewebsites.net/api/Albums/byNameOrArtist/radwimps (Gets Album/Artist by name, in this case "radwimps")
- https://cesarmusicemporiumapi.azurewebsites.net/api/Albums/55 (Get Album with Id 55)
- https://cesarmusicemporiumapi.azurewebsites.net/api/Artists/10 (Get Artist with Id 10)


### UI DEMO LIVE
- To run the deomo app LIVE: https://cesarmusicemporiumwebapp.azurewebsites.net/ (I'm running a low bandwith shared azure resource, so it might take a second or two to load in for the first time)

### UI DEMO LOCAL
- To run the demo app LOCAL, download CesarMusicEmporiumWebapp solution folders.
- In visual studio run solutions, it will open the UI in your localhoast browser
- The UI connects to https://cesarmusicemporiumapi.azurewebsites.net/api/ endpoint to fetch data
- You can either make requests directly from the API using swagger, or use the CesarMusicEmporiumWebApp to make requests
- The webapp should run under https://localhost:7046 (or whichever port number your machine is using)

### UI SCREENSHOT (More screenshots under the Screenshots folder)
![Imgur](https://i.imgur.com/F3pyJSu.png)

## Endpoints

### Get All Albums

Returns a list of all music albums in the database.

#### Request

`GET /Albums`

#### Response

The response will be a JSON array of album objects, each containing the following fields:

- `albumId` (integer): the unique identifier for the album
- `albumName` (string): the name of the album
- `artistName` (string/array): the name of the artist(s)
- `releaseYear` (integer): the year the album was released.
- `genre` (string): the genre of the album

#### Example Request

`GET /Albums`

#### Example Response

```json
[
  {
    "albumId": 1,
    "albumName": "Pretender",
    "artistName": ["Satoshi Fujihara", "Daisuke Ozasa", "Makoto Narazaki", "Masaki Matsuura"],
    "groupName": "Official Hige Dandism",
    "releaseYear": 2019,
    "genre": "Pop/Rock"
  },
  {
    "albumId": 2,
    "albumName": "Subtitle",
    "artistName": ["Satoshi Fujihara", "Daisuke Ozasa", "Makoto Narazaki", "Masaki Matsuura"],
    "groupName": "Official Hige Dandism",
    "releaseYear": 2022,
    "genre": "Pop/Rock"
  }
]
```

### Get Album by ID

Returns the details of a specific album, identified by its `albumId`.

#### Request

`GET /Albums/{albumId}`

#### Parameters

- `albumId` (integer, required): the unique identifier for the album

#### Response

The response will be a JSON object containing the following fields:

- `albumId` (integer): the unique identifier for the album
- `albumName` (string): the name of the album
- `artistName` (string/array): the name of the artist(s)
- `releaseYear` (integer): the year the album was released.
- `genre` (string): the genre of the album

#### Example Request

`GET /albums/1`

#### Example Response

```json
{
  "albumId": 1,
  "albumName": "Pretender",
  "artistName": "Official Hige Dandism",
  "releaseYear": 2019,
  "genre": "Pop/Rock"
}
```

### Get Album by NameOrArtist

Returns the details of a specific album, identified by a given `stringQuery` parameter.

#### Request

`GET /Albums/byNameOrArtist/{searchText}`

#### Parameters

- `searchText` (string): search parameter in string format

#### Response

The response will be a JSON object containing the following fields:

- `albumId` (integer): the unique identifier for the album
- `albumName` (string): the name of the album
- `artistName` (string/array): the name of the artist(s)
- `releaseYear` (integer): the year the album was released.
- `genre` (string): the genre of the album

#### Example Request

`GET /Albums/byNameOrArtist/official`

#### Example Response

```json
[
  {
    "albumId": 10,
    "albumName": "Traveler",
    "artistName": "Official HIGE DANDism",
    "releaseYear": 2019,
    "genre": "Pop"
  },
  {
    "albumId": 20,
    "albumName": "Vivarium",
    "artistName": "Official HIGE DANDism",
    "releaseYear": 2021,
    "genre": "Pop"
  }
]
```

### Get All Artists

Returns a list of all music artists/groups in the database.

#### Request

`GET /Artists`

#### Response

The response will be a JSON array of artist objects, each containing the following fields:

- `artistId` (integer): the unique identifier for the artist
- `artistName` (string/array): the name of the artist(s)
- `groupName` (string): the name of the group
- `formedYear` (integer): the year the artist(s) began working
- `genre` (string): the genre of the artist's music

#### Example Request

`GET /Artists`

#### Example Response

```json
[
  {
    "artistId": 1,
    "artistName": ["Satoshi Fujihara", "Daisuke Ozasa", "Makoto Narazaki", "Masaki Matsuura"],
    "groupName": "Official Hige Dandism",
    "formedYear": 2012,
    "genre": "Pop/Rock"
  },
  {
    "artistId": 2,
    "artistName": ["Ikuta Lilas", "Ayase"],
    "groupName": "YOASOBI",
    "formedYear": 2019,
    "genre": "J-Pop"
  }
]
```

### Get Artist by ID

Returns the details of a specific artist, identified by their `artistId`.

#### Request

`GET /Artists/{artistId}`

#### Parameters

- `artistId` (integer, required): the unique identifier for the artist

#### Response

The response will be a JSON object containing the following fields:

- `artistId` (integer): the unique identifier for the artist
- `artistName` (string/array): the name of the artist(s)
- `formedYear` (integer): the year the group was formed.
- `genre` (string): the genre of the artist's music

#### Example Request

`GET /Artists/1`

#### Example Response

```json
{
  "artistId": 1,
  "artistName": ["Ikuta Lilas", "Ayase"],
  "groupName": "YOASOBI",
  "formedYear": 2019,
  "genre": "J-Pop"
}
```
