import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ordem-compra',
  templateUrl: './ordem-compra.component.html',
  styleUrls: ['./ordem-compra.component.css']
})
export class OrdemCompraComponent implements OnInit {

  public endereco = '';
  public numero = '';
  public complemento = '';
  public formaPagamento = '';

  constructor() { }

  ngOnInit() {
  }

  public atualizaEndereco(endereco: string) {
    this.endereco = endereco;
    console.log(this.endereco);
  }

  public atualizaNumero(numero: string) {
    this.numero = numero;
    console.log(this.numero);
  }

  public atualizaComplemento(complemento: string) {
    this.complemento = complemento;
    console.log(this.complemento);
  }

  public atualizaFormaPagamento(formaPagamento: string) {
    this.formaPagamento = formaPagamento;
    console.log(this.formaPagamento);
  }
}
