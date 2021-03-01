using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceDTO
{
    public class Speaker
    {
        public int Id { get; set; }

        /// <summary>
        /// Name of the Speaker
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        /// <summary>
        /// Biography and achivements details
        /// </summary>
        [StringLength(4000)]
        public string Bio { get; set; }


        /// <summary>
        /// Where to find more information aabout the speaker.
        /// </summary>
        [StringLength(1000)]
        public virtual string WebSite { get; set; }
    }
}
