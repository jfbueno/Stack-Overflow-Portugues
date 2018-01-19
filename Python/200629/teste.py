strEntrada = input("Digite o valor correspondente ao lado de um quadrado: ")

try:
    LadodoQuadrado = int(strEntrada)
except ValueError:
	print('entre com um número inteiro')
	exit()	

variavel = float(LadodoQuadrado)

x = LadodoQuadrado * 4

y = LadodoQuadrado ^ 2

print("perímetro:", x, "área:", y)