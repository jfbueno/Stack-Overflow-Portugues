pessoas = []
idades = []
for c in range(3):
    pessoas.append(input('Digite o nome da pessoa: '))
    idades.append(int(input('Digite agora a idade da pessoa: ')))

menor_idade = min(idades)         # Obtém o menor valor em 'idades'
index = idades.index(menor_idade) # Obtém o index deste valor

print(f'{pessoas[index]} é a pessoa mais nova, com {menor_idade} anos') 
