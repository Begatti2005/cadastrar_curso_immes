import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CursoService } from '../../services/curso.service';

@Component({
  selector: 'app-curso-adicionar',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './curso-adicionar.component.html',
  styleUrl: './curso-adicionar.component.css'
})
export class CursoAdicionarComponent {
  constructor(private cursoService: CursoService) {}

  curso: any = {
    nome: '',
    periodo: 1
  }

  periodos: any[] = [
    { id: 1, descricao: 'Manhã' },
    { id: 2, descricao: 'Tarde' },
    { id: 3, descricao: 'Noite' }
  ];

  adicionar() {
    this.cursoService.adicionar(this.curso).subscribe({
      next: (response) => {
        alert(response.mensagem);
      },
      error: (error) => {
        console.log(error);
      },
      complete: () => {
        console.log('Adicionar curso completo');
      }
    })
  }

  adicionar2() {
    this.cursoService.adicionar(this.curso).subscribe(response => {
      alert(response.mensagem)
    }, error => {
      console.error(error);
    });
  }  


  /*
  
    getData() {
    this.http.get('/api/data')
      .subscribe(
        (response) => {
          // Handle the successful response
        },
        (error) => {
          this.errorHandler.handle(error); // Centralized error handling
        }
      );
  }
  
  
  */
}
