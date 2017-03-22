using System;
using System.ComponentModel.DataAnnotations;
using OnlineBanking.Models.Contract;
using OnlineBanking.Service;

namespace OnlineBanking.Models
{
    public class Client : IEntity
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContractNumber { get; set; }
        public  string Phone { get; set; }
        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        public DateTime DateOfBirth { get; set; }
        public bool Deposit { get; set; }

        public int? StatusId { get; set; }
        public virtual Status Status { get; set; }

        public bool IsValid()
        {
           
            if (!FirstName.InRange(3, 30))
            {
                Logger.Log.ErrorFormat("FirstName invalid");
                return false;
            }
            if (!LastName.InRange(3, 30))
            {
                Logger.Log.ErrorFormat("LastName invalid");
                return false;
            }
            if (!Phone.IsPhone())
            {
                Logger.Log.ErrorFormat("Phone invalid");
                return false;
            }
            if (DateOfBirth > DateTime.Now)
            {
                Logger.Log.ErrorFormat("DateOfBirth invalid");
                return false;
            }
            return true;
        }
    }
}