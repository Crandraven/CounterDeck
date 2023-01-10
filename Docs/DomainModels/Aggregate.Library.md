# Domain Models

## Library

```csharp
class Library
{
    Library Create();
    void AddCard(Card card);
    void RemoveCard(Card card);
}
```

```json
{
    "id": { "value": "00000000-0000-0000-0000-00000000" },
    "name": "name",
    "cmc": 5,
    "createdDateTime": "2023-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2023-01-01T00:00:00.0000000Z"
}
```