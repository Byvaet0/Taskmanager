namespace Taskmanager.Api.Models
{
    public class CommonObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[] Photo { get; set; }

        public CommonObject()
        { 
            CreationDate = DateTime.Now;
        }
    }
}
