namespace api_linq;
using System.Text.Json.Serialization;

public class Musica
{
    private static Dictionary<int, string>? KeyTonalidade => new()
    {
        { 0, "C" },
        { 1, "C#" },
        { 2, "D" },
        { 3, "D#" },
        { 4, "E" },
        { 5, "F" },
        { 6, "F#" },
        { 7, "G" },
        { 8, "G#" },
        { 9, "A" },
        { 10, "A#" },
        { 11, "B" }
    };

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("explicit")]
    public string? Explicito { get; set; } // é booleano

    [JsonPropertyName("year")]
    public string? Ano { get; set; } // é int

    [JsonPropertyName("popularity")]
    public string? Popularidade { get; set; } // é int

    [JsonPropertyName("danceability")]
    public string? Dancabilidade { get; set; } // é double

    [JsonPropertyName("energy")]
    public string? Energia { get; set; } // é double

    [JsonPropertyName("key")]
    public int Chave { get; set; }

    public string chave_tonalidade => KeyTonalidade![Chave];

    [JsonPropertyName("loudness")]
    public string? Ruido { get; set; } // é double

    [JsonPropertyName("mode")]
    public string? Modo { get; set; } // é int

    [JsonPropertyName("speechiness")]
    public string? Fala { get; set; } // é double

    [JsonPropertyName("acousticness")]
    public string? Acustica { get; set; } // é double

    [JsonPropertyName("instrumentalness")]
    public string? Instrumental { get; set; } // é double

    [JsonPropertyName("liveness")]
    public string? Vida { get; set; } // é double

    [JsonPropertyName("valence")]
    public string? Valencia { get; set; } // é double

    [JsonPropertyName("tempo")]
    public string? Tempo { get; set; } // é double

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao / 1000} segundos");
        Console.WriteLine($"Explicito: {Explicito}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Popularidade: {Popularidade}");
        Console.WriteLine($"Dancabilidade: {Dancabilidade}");
        Console.WriteLine($"Energia: {Energia}");
        Console.WriteLine($"Chave: {Chave}");
        Console.WriteLine($"Chave Tonalidade: {chave_tonalidade}");
        Console.WriteLine($"Ruido: {Ruido}");
        Console.WriteLine($"Modo: {Modo}");
        Console.WriteLine($"Fala: {Fala}");
        Console.WriteLine($"Acustica: {Acustica}");
        Console.WriteLine($"Instrumental: {Instrumental}");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Valencia: {Valencia}");
        Console.WriteLine($"Tempo: {Tempo}");
        Console.WriteLine($"Genero: {Genero}");
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
    }
}