# Domain Models

## Collection

```csharp
class Collection
{
    Collection CreateUnique();
    void AddCard(Card card);
    void RemoveCard(Card card);
}
```

```json
{
    "id": { "value": "00000000-0000-0000-0000-00000000" },
    "numberOfCards": 154,
    "cardIds": [
        { "value": "00000000-0000-0000-0000-00000000" }
    ],
    "userId": { "value": "00000000-0000-0000-0000-00000000" },
    "createdDateTime": "2023-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2023-01-01T00:00:00.0000000Z",
}
```