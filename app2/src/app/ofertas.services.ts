import { Oferta } from './shared/oferta.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { URLAPI } from './app.api';

@Injectable()
export class OfertasService {

    constructor(private http: HttpClient) { }

    public getOfertas() {
        return this.http.get<Oferta[]>(`${URLAPI}ofertas?destaque=true`)
            .toPromise()
            .then((res: any) => res);
    }

    public getOfertaPorCategoria(categoria: string) {
        return this.http.get<Oferta[]>(`${URLAPI}ofertas?categoria=${categoria}`)
            .toPromise()
            .then((res: any) => res);
    }

    public getOfertaPorId(id: number) {
        return this.http.get<Oferta>(`${URLAPI}ofertas?id=${id}`)
            .toPromise()
            .then((res: any) => res.shift());
    }
}
