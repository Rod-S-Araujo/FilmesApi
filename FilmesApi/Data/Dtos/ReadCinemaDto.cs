namespace FilmesApi.Data.Dtos;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string nome { get; set; }
    public ReadEnderecoDto Endereco { get; set; }
    public ICollection<ReadSessaoDto> Sessoes { get; set; }
}
