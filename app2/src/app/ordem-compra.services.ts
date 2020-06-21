import { Pedido } from './shared/pedido.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { URLAPI } from './app.api';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable()
export class OrdemCompraService {

    constructor(private http: HttpClient) { }

    public efetivarCompra(pedido: Pedido): Observable<any> {
        return this.http.post(`${URLAPI}/pedidos`, pedido).pipe(
            map((response: any) => console.log(response))
        );
    }
}
