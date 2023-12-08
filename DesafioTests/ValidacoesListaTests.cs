using DesafioConsole.Services;

namespace DesafioTests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var numero = 9;

        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numero);

        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var numero = 10;

        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numero);

        Assert.False(resultado);
    }
}