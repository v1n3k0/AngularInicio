import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { Frase } from '../shared/frase.model';
import { FRASES } from './frases-mock';

@Component({
  selector: 'app-painel',
  templateUrl: './painel.component.html',
  styleUrls: ['./painel.component.css']
})
export class PainelComponent implements OnInit {

  public frases: Frase[] = FRASES;
  public instrucao = 'Traduza a frase:';
  public resposta = '';

  public rodada = 0;
  public rodadaFrase: Frase;
  public progresso = 0;

  public tentativas = 3;

  @Output() public encerrarJogo: EventEmitter<string> = new EventEmitter();

  constructor() {
    this.atualizaRodada();
  }

  ngOnInit() {
  }

  public atualizarResposta(resposta: Event): void {
    this.resposta = (resposta.target as unknown as HTMLInputElement).value;
  }

  public verificarResposta(): void {
    if (this.rodadaFrase.frasePtBr === this.resposta) {

      this.rodada++;

      this.progresso = this.progresso + (100 / this.frases.length);

      if (this.rodada === 4) {
        this.encerrarJogo.emit('Vitoria');
      }

      this.atualizaRodada();
    } else {
      this.tentativas--;
    }

    if (this.tentativas === -1) {
      this.encerrarJogo.emit('Derrota');
    }
  }

  public atualizaRodada(): void {
    this.rodadaFrase = this.frases[this.rodada];
    this.resposta = '';
  }

}
