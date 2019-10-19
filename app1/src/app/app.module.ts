import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TopoComponent } from './topo/topo.component';
import { PainelComponent } from './painel/painel.component';
import { TentativaComponent } from './tentativa/tentativa.component';
import { ProgressoComponent } from './progresso/progresso.component';

@NgModule({
  declarations: [
    AppComponent,
    TopoComponent,
    PainelComponent,
    TentativaComponent,
    ProgressoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
