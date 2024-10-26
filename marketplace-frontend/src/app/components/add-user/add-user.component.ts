import { Component } from '@angular/core';
import { UserService } from '../../Services/user.service';
import { NgModel } from '@angular/forms';


@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss'],

})
export class AddUserComponent {
  user = {
    nome: '',
    email: '',
    senha: '',
    tipo: 'Consumidor'
  };

  constructor(private userService: UserService) { }

  onSubmit() {
    this.userService.addUser(this.user).subscribe(() => {
     console.log('seve');
    });
  }
}
