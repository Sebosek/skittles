# Chips

<div class="skittles-components-sample">
    <div class="chip"><span>Winter</span></div>
</div>

```html
<div class="chip"><span>Winter</span></div>
```

## With a close button

<div class="skittles-components-sample">
    <div class="chip">
        <span>Winter</span>
        <div class="chip__close">
            <svg class="icon">
                <use xlink:href="#close" />
            </svg>
        </div>
    </div>
</div>

```html
<div class="chip">
    <span>Winter</span>
    <div class="chip__close">
        <svg class="icon">
            <use xlink:href="#close" />
        </svg>
    </div>
</div>
```

## Combined with Input component

<div class="skittles-components-sample">
    <label class="input">
        <div class="input__label">Input label</div>
        <div class="input__envelope" style="padding-left: 6px;">
            <div class="chip chip--blue">
                <span>Spring</span>
                <div class="chip__close">
                    <svg class="icon">
                        <use xlink:href="#close" />
                    </svg>
                </div>
            </div>
            <div class="chip chip--yellow">
                <span>Winter</span>
                <div class="chip__close">
                    <svg class="icon">
                        <use xlink:href="#close" />
                    </svg>
                </div>
            </div>
            <input class="input__control" type="text">
            <div class="input__icon">
                <svg class="icon"><use xlink:href="#close" /></svg>
            </div>
        </div>
    </label>
</div>

```html
<label class="input">
    <div class="input__label">Input label</div>
    <div class="input__envelope" style="padding-left: 6px;">
        <div class="chip chip--blue">
            <span>Spring</span>
            <div class="chip__close">
                <svg class="icon">
                    <use xlink:href="#close" />
                </svg>
            </div>
        </div>
        <div class="chip chip--yellow">
            <span>Winter</span>
            <div class="chip__close">
                <svg class="icon">
                    <use xlink:href="#close" />
                </svg>
            </div>
        </div>
        <input class="input__control" type="text">
        <div class="input__icon">
            <svg class="icon"><use xlink:href="#close" /></svg>
        </div>
    </div>
</label>
```