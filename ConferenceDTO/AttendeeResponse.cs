using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceDTO
{
    public class AttendeeResponse : Attendee
    {

        public virtual ICollection<Session> Sessions { get; set; }

    }
}
