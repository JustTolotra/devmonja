using System;

namespace WinFormsApp1
{
    public class Subscription
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int MembershipId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Member Member { get; set; }
        public Membership Membership { get; set; }
    }
}