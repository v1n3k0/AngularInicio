import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { OfertasService } from 'src/app/ofertas.services';

@Component({
  selector: 'app-onde-fica',
  templateUrl: './onde-fica.component.html',
  styleUrls: ['./onde-fica.component.css']
})
export class OndeFicaComponent implements OnInit {

  public ondeFica = '';

  constructor(
    private route: ActivatedRoute,
    private ofertaService: OfertasService
  ) { }

  ngOnInit() {
    this.route.params.subscribe((parametros: Params) => {
      this.ofertaService.getOndeFicaPorId(parametros.id)
        .then((resposta: string) => {
          this.ondeFica = resposta;
        });
    });
  }
}
