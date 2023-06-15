static int EncontrarNumero(int[] numeros, int alvo)
{
    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] == alvo)
            return i; // Retorna o índice se o número for encontrado
    }

    return -1; // Retorna -1 se o número não for encontrado
}