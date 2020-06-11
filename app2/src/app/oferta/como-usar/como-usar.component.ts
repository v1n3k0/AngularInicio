import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { OfertasService } from 'src/app/ofertas.services';

@Component({
  selector: 'app-como-usar',
  templateUrl: './como-usar.component.html',
  styleUrls: ['./como-usar.component.css']
})
export class ComoUsarComponent implements OnInit {

  public comoUsar = '';

  constructor(
    private route: ActivatedRoute,
    private ofertaService: OfertasService
  ) { }

  ngOnInit() {
    this.route.params.subscribe((parametros: Params) => {
      this.ofertaService.getComoUsarPorId(parametros.id)
        .then((resposta: string) => {
          this.comoUsar = resposta;
        });
    });
  }

}
