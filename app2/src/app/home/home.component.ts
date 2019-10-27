import { Component, OnInit } from '@angular/core';
import { OfertasService } from '../ofertas.services';
import { Oferta } from '../shared/oferta.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  providers: [OfertasService]
})
export class HomeComponent implements OnInit {

  public ofertas: Oferta[];

  constructor(private ofertasServices: OfertasService) { }

  ngOnInit() {
    //this.ofertas = this.ofertasServices.getOfertas();

    this.ofertasServices.getOfertas2()
      .then((ofertas: Oferta[]) => {
        this.ofertas = ofertas;
      })
      .catch((erro: any) => {
        console.log(erro);
      });
  }

}
