import { Component, OnInit } from '@angular/core';
import { CursoService } from '../../services/curso.service';
import { catchError } from 'rxjs';

@Component({
  selector: 'app-curso-listar',
  standalone: true,
  imports: [],
  templateUrl: './curso-listar.component.html',
  styleUrl: './curso-listar.component.css'
})
export class CursoListarComponent implements OnInit {
  cursos: any[] = [];

  constructor(private cursoService: CursoService) {}

  ngOnInit(): void {
    this.carregarDados();
  }

  carregarDados() {
    this.cursoService.listar().subscribe(dados => {
      this.cursos = dados;
    })    
  }

  remover(cursoId: any) {
    this.cursoService.remover(cursoId).subscribe({
      next: (response) => {
        alert(response.mensagem);
        this.carregarDados();
      },
      error: (error) => {
        alert('Ocorreu um Erro: ' + error.mensagem);
      }
    })
  }
}
