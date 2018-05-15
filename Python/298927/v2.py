class Pessoa:
    def __init__(self, nome, idade):
        self.nome, self.idade, = nome, idade

pessoas = []
for c in range(3):
    nome = input('Digite o nome da pessoa: ')
    idade = int(input('Digite agora a idade da pessoa: '))
    pessoa = Pessoa(nome, idade)
    pessoas.append(pessoa)

pessoa = min(pessoas, key = lambda p: p.idade)

print(f'{pessoa.nome} é a pessoa mais nova, com {pessoa.idade} anos')
