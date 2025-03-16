namespace Tradesies.Models;

public record CreatePostingRequest(
    string Title,
    string Description,
    Decimal Price,
    string Status,
    string Type,
    string Condition,
    string Category,
    User Seller
);

public record RemovePostingRequest(string RemovalReason);

public record CreatePostingBidRequest(decimal Bid, User Bidder);

public record BidAcceptedRequest(User Bidder);

public record PurchaseItemRequest(User Purchaser);
