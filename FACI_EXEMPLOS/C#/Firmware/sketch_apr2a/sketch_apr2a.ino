//SERIAL TEMPERATURA
//IFACI SENAI SÃO CARLOS
//CSTADS
//02/04/2025
//AUTOR: BRUNO DURAN TEODORO

int SENSOR = 0;//DEFINE O PINO ANALÕGICO A0 COMO ENTRADA DO SENSOR
float D = 0;//VARIAVEL PARA ARMAZENAR O VALOR LIDO DO SENSOR(0-1023)
int T = 0;//VARIAVEL PARA ARMAZENAR A TEMPERATURA CALCULADA


void setup(){
  Serial.begin(9600);//INICIA A COMUNICAÇÃO SERIAL COM TAXA DE 9600 BAUDS
}


void loop(){
  D = analogRead(SENSOR);
  T = (D * 5 * 100)/1023;//Converte o valor lido para temperatura
  Serial.print(T);//Envia o valor da temperatura para o serial
  delay(1000);//Aguarda 1 segundo antes da proxia leitura
}

  int main(void){
  init();
  setup();
  for (;;)
    loop();
    return 0;
}

