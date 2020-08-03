namespace command_api.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }

        // For the sake of example, hiding this field in the ReadDTO
        //public string Platform { get; set; }
    }
}