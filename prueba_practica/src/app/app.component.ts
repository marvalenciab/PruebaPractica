import { HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { TarjetaCreditoComponent } from './components/tarjeta-credito/tarjeta-credito.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    TarjetaCreditoComponent,
    ReactiveFormsModule,
    HttpClientModule,
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'prueba_practica';
}
