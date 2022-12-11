# CounterDeck API

- [CounterDeck API](#counterdeck-api)
    - [Auth](#auth)
        - [Register](#register)
            - [Register Request](#register-request)
            - [Registe Response](#register-response)
        - [Login](#login)
            - [Login Request](#login-request)
            - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstname": "Nicolas",
    "lastname": "RUBIO",
    "email": "nicolas@rubio.fr",
    "password": "Nic0@RuB42"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "firstname": "Nicolas",
    "lastname": "RUBIO",
    "email": "nicolas@rubio.fr",
    "token": "eyJhb..z9dqcnXoY"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "nicolas@rubio.fr",
    "password": "Nic0@RuB42"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "firstname": "Nicolas",
    "lastname": "RUBIO",
    "email": "nicolas@rubio.fr",
    "token": "eyJhb..hbbqY"
}
```