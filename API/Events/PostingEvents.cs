namespace Tradesies.Events;

using System;
using Tradesies.Models;
using NodaTime;

public class PostingEvents
{
    public class CreatePostingRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public Instant DatePosted { get; set; }
        public Instant? DateSold { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public Condition Condition { get; set; }
        public Category? Category { get; set; }
        public User Seller { get; set; }

        /*public CreatePostingRequest(*/
        /*    string title,*/
        /*    string description,*/
        /*    string price,*/
        /*    string status,*/
        /*    string type,*/
        /*    Condition condition,*/
        /*    User seller,*/
        /*    Category category*/
        /*)*/
        /*{*/
        /*    this.DatePosted = Instant.FromDateTimeUtc(DateTime.UtcNow);*/
        /*    this.Title = title;*/
        /*    this.Status = "Active";*/
        /*    this.Type = type;*/
        /*    this.Condition = condition;*/
        /*    this.Seller = seller;*/
        /*    this.Description = description;*/
        /*    this.Price = price;*/
        /*}*/
    }

    public class RemovePostingRequest
    {
        public Guid Id { get; set; }
        public string RemovalReason { get; set; }
    }

    /*public RemovePostingRequest(*/
    /*    string title,*/
    /*    string description,*/
    /*    string price,*/
    /*    string status,*/
    /*    string type,*/
    /*    Condition condition,*/
    /*    User seller,*/
    /*    Category category,*/
    /*    string removalReason*/
    /*)*/
    /*{*/
    /*    this.DatePosted = Instant.FromDateTimeUtc(DateTime.UtcNow);*/
    /*    this.Title = title;*/
    /*    this.Status = "Active";*/
    /*    this.Type = type;*/
    /*    this.Condition = condition;*/
    /*    this.Seller = seller;*/
    /*    this.Description = description;*/
    /*    this.Price = price;*/
    /*}*/

    public class CreatePostingBidRequest
    {
      public Guid Id { get; set; }
      public User Bidder { get; set; }
      public decimal Bid { get; set; }
    }

    public class BidAcceptedRequest
    {
      public Guid Id { get; set; }
      public User Bidder {get; set;}
    }

    public class PurchaseItemRequest
    {
      public Guid Id { get; set; }
      public User Purchaser { get; set; }
    }
}


