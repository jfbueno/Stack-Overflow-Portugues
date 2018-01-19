lista = [0, 10, 20, 50, 80, 10]

maior = 0
i = 0
while i < len(lista):
    maior = lista[i] if maior < lista[i] else maior
    i += 1

print('O maior é {}'.format(maior))