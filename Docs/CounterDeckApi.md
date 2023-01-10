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
    "username": "username",
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
    "username": "username",
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
    "username": "username",
    "password": "P@ss0rd!1234"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "username": "username",
    "email": "nicolas@rubio.fr",
    "token": "eyJhb..hbbqY"
}
```