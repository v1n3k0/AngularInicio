import { Pedido } from './shared/pedido.model';

export class OrdemCompraService {
    public efetivarCompra(pedido: Pedido) {
        console.log('Compra efetivada');
    }
}
