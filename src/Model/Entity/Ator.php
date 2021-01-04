<?php
declare(strict_types=1);

namespace App\Model\Entity;

use Cake\ORM\Entity;

/**
 * Ator Entity
 *
 * @property int $id
 * @property string|null $nome
 * @property \Cake\I18n\FrozenDate|null $nascimento
 *
 * @property \App\Model\Entity\Filme[] $filmes
 */
class Ator extends Entity
{
    /**
     * Fields that can be mass assigned using newEntity() or patchEntity().
     *
     * Note that when '*' is set to true, this allows all unspecified fields to
     * be mass assigned. For security purposes, it is advised to set '*' to false
     * (or remove it), and explicitly make individual fields accessible as needed.
     *
     * @var array
     */
    protected $_accessible = [
        'nome' => true,
        'nascimento' => true,
        'filmes' => true,
    ];
}
