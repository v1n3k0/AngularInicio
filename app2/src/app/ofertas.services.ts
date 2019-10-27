import { Oferta } from './shared/oferta.model';
import { resolve, reject } from 'q';

export class OfertasService {

    private ofertas: Oferta[] = [
        {
            id: 1,
            categoria: 'restaurante',
            titulo: 'Super Burger',
            descricaoOferta: 'Rodízio de Mini-hambúrger com opção de entrada.',
            anunciante: 'Original Burger',
            valor: 29.90,
            destaque: true,
            imagens: [
                { url: '/assets/ofertas/1/img1.jpg' },
                { url: '/assets/ofertas/1/img2.jpg' },
                { url: '/assets/ofertas/1/img3.jpg' },
                { url: '/assets/ofertas/1/img4.jpg' }
            ]
        },
        {
            id: 2,
            categoria: 'restaurante',
            titulo: 'Cozinha Mexicana',
            descricaoOferta: 'Almoço ou Jantar com Rodízio Mexicano delicioso.',
            anunciante: 'Mexicana',
            valor: 32.90,
            destaque: true,
            imagens: [
                { url: '/assets/ofertas/2/img1.jpg' },
                { url: '/assets/ofertas/2/img2.jpg' },
                { url: '/assets/ofertas/2/img3.jpg' },
                { url: '/assets/ofertas/2/img4.jpg' }
            ]

        },
        {
            id: 4,
            categoria: 'diversao',
            titulo: 'Estância das águas',
            descricaoOferta: 'Diversão garantida com piscinas, trilhas e muito mais.',
            anunciante: 'Estância das águas',
            valor: 31.90,
            destaque: true,
            imagens: [
                { url: '/assets/ofertas/3/img1.jpg' },
                { url: '/assets/ofertas/3/img2.jpg' },
                { url: '/assets/ofertas/3/img3.jpg' },
                { url: '/assets/ofertas/3/img4.jpg' },
                { url: '/assets/ofertas/3/img5.jpg' },
                { url: '/assets/ofertas/3/img6.jpg' }
            ]
        }
    ];

    public getOfertas(): Array<any> {
        return this.ofertas;
    }

    public getOfertas2(): Promise<Array<Oferta>> {
        return new Promise((resolve, reject) => {
            const certo = true;
            if (certo) {
                console.log('Esperando 3 segundos');
                setTimeout(() => resolve(this.ofertas), 3000);
            } else {
                reject({ erro: 401, mensagem: 'Servidor não disponivel' });
            }
        }).then((ofertas: Oferta[]) => {
            console.log('Primeiro then');
            return ofertas;
        }).then((ofertas: Oferta[]) => {
            return new Promise((resolve2, reject2) => {
                console.log('Segundo then esperando 3 segundos');
                setTimeout(() => resolve2(ofertas), 3000);
            });
        });
    }
}
