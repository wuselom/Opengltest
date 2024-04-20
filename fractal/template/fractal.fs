#version 330

in vec3 pos;

out vec4 fragColor;

vec2 f(vec2 z, vec2 c)
{
    return vec2(z.x * z.x - z.y * z.y, 2 * z.x * z.y) + c;
}


void main()
{
    vec2 c = pos.xy;
    c.x -= 0.5;
    vec2 z = vec2(0,0);

    int i=0;
    while(i<100 && length(z)<4) {
        z = f(z,c);
        i++;
    }
    float color = i / 100.0;

    fragColor = vec4(color,color,color,1);


}

