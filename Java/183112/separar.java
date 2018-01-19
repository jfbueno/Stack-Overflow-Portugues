String input = "A1B2C3D2Z9®*#"; //adicionei uns símbolos pro exemplo fazer sentido

List<Character> letras = new ArrayList<>();
List<Character> numeros = new ArrayList<>();
List<Character> outros = new ArrayList<>();

for (char c : input.toCharArray()) {
    if (Character.isDigit(c)) {
        numeros.add(c);
    } else if (Character.isLetter(c)) {
        letras.add(c);
    } else {
        outros.add(c);
    } 
}