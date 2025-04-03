void setup() {
  // Inicializa a comunicação serial com a taxa de 9600 baud
  Serial.begin(9600);
}

void loop() {
  // Verifica se há dados disponíveis para ler
  if (Serial.available() > 0) {
    // Lê os dados da porta serial
    String receivedData = Serial.readString();
    
    // Envia os dados recebidos de volta para a porta serial
    Serial.println("Recebido: " + receivedData);
    
    // Adiciona um pequeno delay para evitar leitura excessiva
    delay(100);
  }
}
