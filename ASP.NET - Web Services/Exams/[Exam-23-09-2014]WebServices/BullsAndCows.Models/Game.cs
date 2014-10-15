using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows.Models
{
    public class Game
    {
        public Game()
        {
            this.Id = Guid.NewGuid();
            this.State = GameState.WaitingForSecondPlayer;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime? CreatedDate { get; set; }

        public GameState State { get; set; }

        [Required]
        public virtual ApplicationUser RedPlayer { get; set; }

        public string RedPlayerId { get; set; }

        public ApplicationUser BluePlayer { get; set; }

        public virtual string BluePlayerId { get; set; }
    }
}