<?php
declare(strict_types=1);

namespace App\Model\Table;

use Cake\ORM\Query;
use Cake\ORM\RulesChecker;
use Cake\ORM\Table;
use Cake\Validation\Validator;

/**
 * Ators Model
 *
 * @property \App\Model\Table\FilmesTable&\Cake\ORM\Association\BelongsToMany $Filmes
 *
 * @method \App\Model\Entity\Ator newEmptyEntity()
 * @method \App\Model\Entity\Ator newEntity(array $data, array $options = [])
 * @method \App\Model\Entity\Ator[] newEntities(array $data, array $options = [])
 * @method \App\Model\Entity\Ator get($primaryKey, $options = [])
 * @method \App\Model\Entity\Ator findOrCreate($search, ?callable $callback = null, $options = [])
 * @method \App\Model\Entity\Ator patchEntity(\Cake\Datasource\EntityInterface $entity, array $data, array $options = [])
 * @method \App\Model\Entity\Ator[] patchEntities(iterable $entities, array $data, array $options = [])
 * @method \App\Model\Entity\Ator|false save(\Cake\Datasource\EntityInterface $entity, $options = [])
 * @method \App\Model\Entity\Ator saveOrFail(\Cake\Datasource\EntityInterface $entity, $options = [])
 * @method \App\Model\Entity\Ator[]|\Cake\Datasource\ResultSetInterface|false saveMany(iterable $entities, $options = [])
 * @method \App\Model\Entity\Ator[]|\Cake\Datasource\ResultSetInterface saveManyOrFail(iterable $entities, $options = [])
 * @method \App\Model\Entity\Ator[]|\Cake\Datasource\ResultSetInterface|false deleteMany(iterable $entities, $options = [])
 * @method \App\Model\Entity\Ator[]|\Cake\Datasource\ResultSetInterface deleteManyOrFail(iterable $entities, $options = [])
 */
class AtorsTable extends Table
{
    /**
     * Initialize method
     *
     * @param array $config The configuration for the Table.
     * @return void
     */
    public function initialize(array $config): void
    {
        parent::initialize($config);

        $this->setTable('ators');
        $this->setDisplayField('id');
        $this->setPrimaryKey('id');

        $this->belongsToMany('Filmes', [
            'foreignKey' => 'ator_id',
            'targetForeignKey' => 'filme_id',
            'joinTable' => 'ators_filmes',
        ]);
    }

    /**
     * Default validation rules.
     *
     * @param \Cake\Validation\Validator $validator Validator instance.
     * @return \Cake\Validation\Validator
     */
    public function validationDefault(Validator $validator): Validator
    {
        $validator
            ->integer('id')
            ->allowEmptyString('id', null, 'create');

        $validator
            ->scalar('nome')
            ->maxLength('nome', 100)
            ->allowEmptyString('nome');

        $validator
            ->date('nascimento')
            ->allowEmptyDate('nascimento');

        return $validator;
    }
}
