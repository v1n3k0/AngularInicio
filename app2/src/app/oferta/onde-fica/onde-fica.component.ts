import { Component, OnInit } from '@angular/core';
import { ActivatedRoute} from '@angular/router';
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
    this.ofertaService.getOndeFicaPorId(this.route.parent.snapshot.params.id)
      .then((resposta: string) => {
        this.ondeFica = resposta;
      });
  }

}
