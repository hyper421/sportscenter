﻿namespace SportsCenter.Models
{
    public class MessageViewModel
    {


        public int Id { get; set; }

        public int MemberId { get; set; }
        public int PostId { get; set; }
        public string Body { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
