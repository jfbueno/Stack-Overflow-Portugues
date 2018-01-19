m = []
for i in range(4):
    linha = []
    for j in range(4):
        linha.append(int(input()))

    m.append(linha)

print(i)

maior_linha = 0
maior_coluna = 0
maior = 0
for linha in range(4):
    for coluna in range(4):        
        if maior < m[linha][coluna]:
            maior = m[linha][coluna]
            maior_linha = linha
            maior_coluna = coluna

print('linha do maior: {}\ncoluna do maior: {}'.format(linha, coluna))