# Dropdown

Dropdown component is made by an `input` and `menu` components with additional `dropdown` block style which defines a behavior of completed dropdown component.

<div class="skittles-components-sample">
    <label class="input dropdown">
        <div class="input__label">Input label</div>
        <div class="input__envelope">
            <input class="input__control" type="text" value="Dropdown item" readonly>
            <div class="input__icon">
                <svg class="icon"><use xlink:href="#chevron-down" /></svg>
            </div>
        </div>
        <section class="menu menu--spread menu--float">
            <ul class="menu__items">
                <li><a class="menu__item" href="">Itemos numeros unos</a></li>
                <li><a class="menu__item" href="">Item la duo</a></li>
            </ul>
        </section>
    </label>
</div>