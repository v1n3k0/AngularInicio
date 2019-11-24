import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { OfertasService } from '../ofertas.services';
import { Observable, interval, Observer } from 'rxjs';
import { Oferta } from '../shared/oferta.model';

@Component({
  selector: 'app-oferta',
  templateUrl: './oferta.component.html',
  styleUrls: ['./oferta.component.css'],
  providers: [OfertasService]
})
export class OfertaComponent implements OnInit {

  public oferta: Oferta;

  constructor(
    private route: ActivatedRoute,
    private ofertasService: OfertasService
  ) { }

  ngOnInit() {
    this.ofertasService.getOfertaPorId(this.route.snapshot.params.id)
      .then((oferta: Oferta) => {
        this.oferta = oferta;
      });


    //   const tempo = interval(2000);

    //   tempo.subscribe((intervalo: number) => {
    //     console.log(intervalo);
    //   });

    const meuObservable = new Observable(
      (observe: Observer<number>) => {
        observe.next(1);
        observe.next(2);
        observe.complete();
      });

    meuObservable.subscribe(
      (resultado: number) => console.log(resultado + 10),
      (erro: string) => console.log(erro),
      () => console.log('Finalizada')
    );
  }

}
