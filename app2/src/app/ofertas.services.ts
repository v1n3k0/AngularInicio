import { Oferta } from './shared/oferta.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { URLAPI } from './app.api';
import { Observable } from 'rxjs/internal/Observable';
import { map, retry } from 'rxjs/operators';

@Injectable()
export class OfertasService {

    constructor(private http: HttpClient) { }

    public getOfertas() {
        return this.http.get<Oferta[]>(`${URLAPI}/ofertas?destaque=true`)
            .toPromise()
            .then((res: any) => res);
    }

    public getOfertaPorCategoria(categoria: string) {
        return this.http.get<Oferta[]>(`${URLAPI}/ofertas?categoria=${categoria}`)
            .toPromise()
            .then((res: any) => res);
    }

    public getOfertaPorId(id: number) {
        return this.http.get<Oferta>(`${URLAPI}/ofertas?id=${id}`)
            .toPromise()
            .then((res: any) => res.shift());
    }

    public getComoUsarPorId(id: number) {
        return this.http.get<string>(`${URLAPI}/como-usar?id=${id}`)
            .toPromise()
            .then((res: any) => res.shift().descricao);
    }

    public getOndeFicaPorId(id: number) {
        return this.http.get<string>(`${URLAPI}/onde-fica?id=${id}`)
            .toPromise()
            .then((res: any) => res.shift().descricao);
    }

    public pesquisaOfertas(termo: string): Observable<Oferta[]> {
        return this.http.get(`${URLAPI}/ofertas?descricao_oferta_like=${termo}`)
        .pipe(map((resposta: any) => resposta), retry(10));
    }
}
