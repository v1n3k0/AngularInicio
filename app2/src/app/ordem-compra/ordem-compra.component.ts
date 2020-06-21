import { Component, OnInit } from '@angular/core';
import { OrdemCompraService } from '../ordem-compra.services';

@Component({
  selector: 'app-ordem-compra',
  templateUrl: './ordem-compra.component.html',
  styleUrls: ['./ordem-compra.component.css'],
  providers: [OrdemCompraService]
})
export class OrdemCompraComponent implements OnInit {

  public endereco = '';
  public numero = '';
  public complemento = '';
  public formaPagamento = '';

  public enderecoValido: boolean;
  public numeroValido: boolean;
  public complementoValido: boolean;
  public formaPagamentoValido: boolean;

  public enderecoEstadoPrimitivo = true;
  public numeroEstadoPrimitivo = true;
  public complementoEstadoPrimitivo = true;
  public formaPagamentoEstadoPrimitivo = true;

  constructor(private ordemCompraService: OrdemCompraService) { }

  ngOnInit() {
    // this.ordemCompraService.efetivarCompra();
  }

  public atualizaEndereco(endereco: string) {
    this.endereco = endereco;
    // console.log(this.endereco);

    this.enderecoEstadoPrimitivo = false;

    if (this.endereco.length > 3) {
      this.enderecoValido = true;
    } else {
      this.enderecoValido = false;
    }
  }

  public atualizaNumero(numero: string) {
    this.numero = numero;
    // console.log(this.numero);

    this.numeroEstadoPrimitivo = false;

    if (this.numero.length > 0) {
      this.numeroValido = true;
    } else {
      this.numeroValido = false;
    }
  }

  public atualizaComplemento(complemento: string) {
    this.complemento = complemento;
    // console.log(this.complemento);

    this.complementoEstadoPrimitivo = false;

    if (this.complemento.length > 0) {
      this.complementoValido = true;
    } else {
      this.complementoValido = false;
    }
  }

  public atualizaFormaPagamento(formaPagamento: string) {
    this.formaPagamento = formaPagamento;
    // console.log(this.formaPagamento);

    this.formaPagamentoEstadoPrimitivo = false;

    if (this.formaPagamento.length > 0) {
      this.formaPagamentoValido = true;
    } else {
      this.formaPagamentoValido = false;
    }
  }
}
