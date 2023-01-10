# Domain Models

## User

```csharp
class User
{
    User Create();
    void AddLibrary(Library library);
    void RemoveLibrary(Library library);
    void UpdateAccount(Account account);
}
```

```json
{
    "id": { "value": "00000000-0000-0000-0000-00000000" },
    "account": {
        "username": "username",
        "password": "P@ssw0rd!1234"
    },
    "email": "nicolas@rubio.com",
    "collectionId": { "value": "00000000-0000-0000-0000-00000000" },
    "librairyIds": [
        { "value": "00000000-0000-0000-0000-00000000" },
    ],
    "createdDateTime": "2023-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2023-01-01T00:00:00.0000000Z",
    "deleted": false
}
```

> Note: Passwords shouldn't be lying arounf like this !