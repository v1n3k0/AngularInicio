import { Oferta } from './shared/oferta.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class OfertasService {

    constructor(private http: HttpClient) { }

    public getOfertas() {
        return this.http.get<Oferta[]>('http://localhost:3000/ofertas?destaque=true')
            .toPromise()
            .then((res: any) => res);
    }

    public getOfertaPorCategoria(categoria: string) {
        return this.http.get<Oferta[]>(`http://localhost:3000/ofertas?categoria=${categoria}`)
            .toPromise()
            .then((res: any) => res);
    }
}
